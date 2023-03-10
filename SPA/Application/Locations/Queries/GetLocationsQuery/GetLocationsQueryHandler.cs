﻿#nullable enable
using JetBrains.Annotations;
using MediatR;
using SPA.Repositories;

namespace SPA.Application.Locations.Queries.GetLocationsQuery;

using Domain;

[UsedImplicitly]
internal class GetLocationsQueryHandler : IRequestHandler<GetLocationsQuery, Page<Location?>>
{
    private readonly ILocationsRepository repository;

    public GetLocationsQueryHandler(ILocationsRepository repository)
    {
        this.repository = repository;
    }

    public async Task<Page<Location?>> Handle(GetLocationsQuery request, CancellationToken cancellationToken)
    {
        return await repository.Get(request.PageNumber, request.PageSize);
    }
}