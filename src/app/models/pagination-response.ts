export interface PaginationResponse<T> {
  data: T[]; 
  pageIndex: number; 
  pageSize: number; 
  totalCount: number; 
  totalPages: number; 
  hasPreviousPage: boolean;
  hasNextPage: boolean;
}
