﻿using SPA.Application.Queries;
using SPA.Application.Queries.Add;
using SPA.Application.Queries.Get;
using SPA.Application.Queries.GetPage;
using SPA.Models;

namespace SPA.V1.Controllers;

using AutoMapper;
using DataModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/students")]
public sealed class V1StudentsController : Controller
{
    private readonly IMediator mediator;
    private readonly IMapper mapper;

    public V1StudentsController(IMediator mediator, IMapper mapper)
    {
        this.mediator = mediator;
        this.mapper = mapper;
    }

    [HttpGet("")]
    public async Task<IActionResult> GetPage([FromQuery] int page = 0, [FromQuery] int size = 30)
    {
        if (page < 0)
            return BadRequest("Page must not be less than 0");
        if (size < 1)
            return BadRequest("Size must not be less than 1");

        var getTutorsQuery = new GetPageQuery<Student>(page, size);
        var tutors = await mediator.Send(getTutorsQuery);
        var t = mapper.Map<V1PageDto<V1StudentDto>>(tutors);

        return Ok(t);
    }
    
    [HttpGet("{id:int}")]
    public async Task<IActionResult> Get(int id)
    {
        var getStudentQuery = new GetQuery<Student>(id);
        var student = await mediator.Send(getStudentQuery);
        return Ok(mapper.Map<V1StudentDto>(student));
    }
    
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] V1StudentDto student)
    {
        var newStudent = mapper.Map<Student>(student);
        var addStudentQuery = new AddQuery<Student>(newStudent);
        return Ok(await mediator.Send(addStudentQuery));
    }
    
    [HttpPatch("{id:int}/update")]
    public async Task<IActionResult> Update(int id, [FromBody] V1StudentDto oldStudent)
    {
        var student = mapper.Map<Student>(oldStudent);
        student.Id = id;
        var updateStudentQuery = new AddQuery<Student>(student);
        return Ok(await mediator.Send(updateStudentQuery));
    }
}