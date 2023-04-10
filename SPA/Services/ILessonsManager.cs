﻿#nullable enable

using SPA.Domain;

namespace SPA.Services;

public interface ILessonsManager
{
    Task<Lesson?> BookAsync(Guid lessonId, Guid studentId);
    Task<Lesson?> CreateAsync(Guid tutorId, double price, LessonType type, DateTimeOffset start, DateTimeOffset end);
    Task<Lesson?> DeleteAsync(Guid id);
}