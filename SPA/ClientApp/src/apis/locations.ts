import axiosInstance, { PaginatedResponse } from './_share';

export interface Location {
  id: string;
  city: string;
  district: string;
}

export interface LocationList extends PaginatedResponse<Location> {}

export default class LocationAPI {
  static async getLocations(
    page: number = 0,
    size: number = 30
  ): Promise<LocationList> {
    const response = await axiosInstance.get('/api/v1/locations', {
      params: { page, size },
    });
    return response.data as LocationList;
  }

  static async getLocationById(id: string): Promise<Location> {
    const response = await axiosInstance.get(`/api/v1/locations/${id}`);
    return response.data as Location;
  }
}
