export interface LoginRequest {
  email: string;
  password: string;
}

export interface LoginResponse {
  tokenType: string;
  accessToken: string; // Matched to Postman
  expiresIn: number;
  refreshToken: string;
}