﻿namespace SPA.Domain;

using Entities;

public sealed class Lesson
{
    public Guid Id { get; init; }

    public double Price { get; init; }

    public LessonStatus Status { get; init; }

    public DateTimeOffset Start { get; init; }

    public DateTimeOffset End { get; init; }

    public Student Student { get; init; }

    public Tutor Tutor { get; init; }
}