import { Injectable } from '@angular/core';
import { UserLogin } from '../../Model/UserLogin';
//import { Department } from '../../Model/Department';
//import { Employee } from '../../Model/Employee';
//import { Position } from '../../Model/Position';

import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class ManagerService
{
  //API
  private userLoginUrl = 'https://localhost:5001/api/Manager/GetAllUserLogin';

  constructor(private http: HttpClient)
  { }

  getUserLogin(): Observable<UserLogin[]>
  {
    return this.http.get<UserLogin[]>(this.userLoginUrl);
  }

}
