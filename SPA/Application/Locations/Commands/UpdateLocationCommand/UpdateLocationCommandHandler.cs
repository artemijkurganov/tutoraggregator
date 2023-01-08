﻿using JetBrains.Annotations;
using MediatR;
using SPA.Models;
using SPA.Repositories;

namespace SPA.Application.Locations.Commands.UpdateLocationCommand;

[UsedImplicitly]
internal class UpdateLocationCommandHandler : IRequestHandler<UpdateLocationCommand, Location> 
{
    private readonly ICrudRepository<Location> repository;
    
    public UpdateLocationCommandHandler(ICrudRepository<Location> repository)
    {
        this.repository = repository;
    }

    public async Task<Location> Handle(UpdateLocationCommand request, CancellationToken cancellationToken)
    {
        return await repository.Update(request.Element);
    }
}