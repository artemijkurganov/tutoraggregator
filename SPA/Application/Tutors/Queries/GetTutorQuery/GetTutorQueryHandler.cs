﻿using JetBrains.Annotations;
using MediatR;
using SPA.Repositories;

namespace SPA.Application.Tutors.Queries.GetTutorQuery;

using Domain;
using Entities;

[UsedImplicitly]
internal class GetTutorQueryHandler : IRequestHandler<GetTutorQuery, Tutor> 
{
    private readonly ITutorsRepository repository;
    
    public GetTutorQueryHandler(ITutorsRepository repository)
    {
        this.repository = repository;
    }

    public async Task<Tutor> Handle(GetTutorQuery request, CancellationToken cancellationToken)
    {
        return await repository.Get(request.Id);
    }
}