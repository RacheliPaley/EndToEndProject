import { Component, OnDestroy, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { UserService } from '../services/user.service';

@Component({
  selector: 'app-init',
  templateUrl: './init.component.html',
  styleUrls: ['./init.component.scss']
})
export class InitComponent implements OnInit,OnDestroy {
  user = null;
  sub: Subscription;
  constructor(public userSer: UserService) { }
  ngOnDestroy(): void {
    this.sub.unsubscribe();
  }

  ngOnInit(): void {
    this.sub = this.userSer.currentUser.subscribe(succ => {
      this.user = this.userSer.getFromStorage()
      console.log("from subscribe")

      

      
    })

  }
  logOut() {

    this.userSer.removeFromStorage()
    this.userSer.currentUser.next(null);

  }

}


