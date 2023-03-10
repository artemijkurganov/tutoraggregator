﻿using SPA.Domain;

namespace SPA.Repositories;

internal interface ILessonRepository
{
    Task<Lesson> GetAsync(Guid id);
    Task<ICollection<Lesson>> GetStudentLessonsAsync(Guid studentId);
    Task<ICollection<Lesson>> GetTutorLessonsAsync(Guid tutorId);
    Task<Lesson> InsertAsync(Guid tutorId, Lesson lesson);
    Task DeleteAsync(Guid id);
    Task<Lesson> BookAsync(Guid studentId, Guid lessonId);
    Task<Lesson> CancelAsync(Guid lessonId);
}