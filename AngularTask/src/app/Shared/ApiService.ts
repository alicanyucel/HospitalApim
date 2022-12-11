import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/internal/operators/map';
@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private http: HttpClient) { }
  postHospital(data: any) {
    return this.http.post<any>("https://localhost:7069/api/Hospital", data)
      .pipe(map((res: any) => {
        return res;
      }))
  }
  getAll() {
    return this.http.get<any>("https://localhost:7069/api/Hospital")
      .pipe(map((res: any) => {
        return res;
      }))

  }
}
