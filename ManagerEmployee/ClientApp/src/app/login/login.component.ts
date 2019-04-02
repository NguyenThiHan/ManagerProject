import { Component, OnInit } from '@angular/core';
import { ManagerService } from '../manager.service';
import { UserLogin } from '../../../Model/UserLogin';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})

export class LoginComponent implements OnInit {

  public username: string;
  public password: string;
  public dbUser: UserLogin[] = [];

  constructor(private managerService: ManagerService)
  { }

  ngOnInit()
  {
    this.getDataUserLogin();
  }
  getDataUserLogin() {
    this.managerService.getUserLogin().subscribe(dbUser => this.dbUser = dbUser);
  }

  CheckLogin() {
    
  }
}
