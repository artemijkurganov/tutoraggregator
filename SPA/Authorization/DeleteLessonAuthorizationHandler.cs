﻿using Microsoft.AspNetCore.Authorization;
using SPA.Authorization.Requirements;
using SPA.Extensions;
using SPA.Repositories;

namespace SPA.Authorization;

internal sealed class DeleteLessonAuthorizationHandler : AuthorizationHandler<IDeleteLessonRequirement, HttpContext>
{
    private readonly ILessonsRepository repository;

    public DeleteLessonAuthorizationHandler(ILessonsRepository repository)
    {
        this.repository = repository;
    }

    protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, IDeleteLessonRequirement requirement, HttpContext resource)
    {
        var userId = context.User.GetId();
        if (userId is null)
            return;
        var lessonId = (string)resource.Request.RouteValues.GetValueOrDefault("id");
        if (!Guid.TryParse(lessonId, out var id))
            return;
        var lesson = await repository.GetAsync(id);
        if (lesson is null)
            return;
        if (requirement.IsUserAuthorized(lesson, userId.Value))
            context.Succeed(requirement);
    }
}