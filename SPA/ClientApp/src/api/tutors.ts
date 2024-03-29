import {
  LessonType,
  V1LessonDto,
  V1ReviewDtoV1PageDto,
  V1TutorDto,
  V1TutorDtoV1PageDto,
} from './models';
import axiosInstance from './_share';

export interface TutorSearchParams {
  subject: string;
  city: string;
  district: string;
  maxPrice: string;
  rating: string;
  lessonType: LessonType;
}

class TutorsAPI {
  static async getAllTutors(
    searchParams: TutorSearchParams = {
      city: null,
      district: null,
      maxPrice: null,
      rating: null,
      subject: null,
      lessonType: LessonType.offline,
    },
    page = 1,
    size = 10
  ): Promise<V1TutorDtoV1PageDto> {
    const response = await axiosInstance.get<V1TutorDtoV1PageDto>(
      '/api/v1/tutors',
      {
        params: {
          page,
          size,
          ...searchParams,
        },
      }
    );
    return response.data;
  }

  static async getTutorById(id: string): Promise<V1TutorDto> {
    const response = await axiosInstance.get<V1TutorDto>(
      `/api/v1/tutors/${id}`
    );
    return response.data;
  }

  static async getReviewsByTutorId(
    tutorId: string,
    page: number = 0,
    size: number = 30
  ): Promise<V1ReviewDtoV1PageDto> {
    const response = await axiosInstance.get<V1ReviewDtoV1PageDto>(
      `/api/v1/tutors/${tutorId}/reviews`,
      {
        params: { page, size },
      }
    );
    return response.data;
  }

  static async addReview(tutorId: string, rating: number, description: string) {
    await axiosInstance.post(`/api/v1/tutors/${tutorId}/reviews`, {
      rating,
      description,
    });
  }

  static async getCurrentProfileInfo(): Promise<V1TutorDto> {
    const response = await axiosInstance.get<V1TutorDto>(
      '/api/v1/tutors/profile'
    );
    return response.data;
  }

  static async putCurrentProfileValues(tutor: V1TutorDto) {
    await axiosInstance.put('api/v1/tutors', { ...tutor });
  }

  static async getAllTutorLessons(): Promise<V1LessonDto[]> {
    const response = await axiosInstance.get<V1LessonDto[]>(
      'api/v1/tutors/current/lessons'
    );
    return response.data;
  }
}

export default TutorsAPI;
