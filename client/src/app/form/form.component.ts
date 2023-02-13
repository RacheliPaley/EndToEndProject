import { Component, OnInit } from '@angular/core';
import Child from '../models/child';
import User from '../models/user';
import { ChildrenService } from '../services/children.service';
import { UserService } from '../services/user.service';
import { Workbook } from 'exceljs';
import * as fs from 'file-saver';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.scss']
})

export class FormComponent implements OnInit {
 loto=null
 idUser=0
 idChild=0
public items = [];
  userP:User = new User(this.idUser++,"","","",new Date(),"","");
  child:Child=new Child(this.idChild++,"",null,"",this.userP.Id);
  constructor(public userService: UserService,public childService:ChildrenService) { 
  }
  arr:User[]
 
  ngOnInit(
    
  ): void {
    this.userP=this.userService.getFromStorage();
    if(this.userP==null)
      this.userP=new User (null,null,null,null,null,null,null)
    console.log( 'init '+this.userP);
   
} 
  public deleteTask(index) {
    this.items.splice(index, 1);
}
public addToList() {
  {
    this.childService.addChild(this.childService.childSer).subscribe( 
      good =>
       { console.log(good), 
      error =>
       { console.log(error);}
       }
    )
 
     this.items.push(this.child);
     this.child = new Child(0,"",null,"");
  }
}
     logIn(){
      this.userService.saveInStorage(this.userService.personSer);
      this.userService.currentUser.next(this.userService.personSer);
      console.log( 'user ' + this.userService.personSer);
      this.userService.addPerson(this.userService.personSer).subscribe
      (good=>
      {console.log(good),
      error=>
      {console.log(error);}
      if(this.userService==null)
       alert("הינך כבר רשום במערכת")
      } 
     )
      this.idUser=this.idUser+1
}
 exportToCsv() {
     var  data = [[ this.userService.personSer],
     this.userService.personSer.Id, this.userService.personSer.Fname,
      this.userService.personSer.Lname, this.userService.personSer.Min,
       this.userService.personSer.Hmo,
    ];
      var CsvString =JSON.stringify(data);
      var anchor = document.createElement("A");
      anchor.setAttribute("href", CsvString);
      anchor.setAttribute("download", "somedata.csv");
      document.body.append(anchor);
      anchor.click();
 } 
}