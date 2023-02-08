import { Component, OnInit } from '@angular/core';
import Child from '../models/child';
import People from '../models/people';
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
  
  userP:People = new People(0,"","","",new Date(),"","");

child:Child=new Child(0,"",null,this.userP.Id);
json_data=[{
  "תז": this.userP.Tz,
  "שם": this.userP.Fname,
  "משפחה":this.userP.Lname,
  "מין":this.userP.Min,
  "קופת חולים":this.userP.Hmo
}

]
  
  constructor(public userService: UserService,public childService:ChildrenService) { 
    
  }
  arr:People[]
  state: any;
   isDispley=false
  ngOnInit(
    
  ): void {

    this.userService.getAllPerson().subscribe((data) => {
      this.arr = data;
      console.log(this.arr)
    }, (err) => {
        alert("התרחשה שגיאה בקבלת הנתונים");
        console.log(err)
    })
    this.userP=this.userService.getFromStorage();
    if(this.userP==null)
    this.userP=new People (null,null,null,null,null,null,null)
    console.log( 'init '+this.userP);
    console.log(this.userP.Fname  );
  }
  addChild(){
this.isDispley=true
  }
  addTheChild(){
    this.childService.addChild(this.childService.childSer).subscribe( good=>{console.log(good),error=>{console.log(error);
    }
    })
    this.isDispley=false
  }
 
     logIn(){
      this.userService.saveInStorage(this.userP);
     this.userService.currentUser.next(this.userP);
     console.log(this.userService.personSer);

     this.userService.addPerson(this.userService.personSer).subscribe(good=>{console.log(good),
      error=>{console.log(error);
        this.downloadExcel()
      }
     } 
     )
    }
  


    downloadExcel(){
      let workbook = new Workbook();
      let worksheet = workbook.addWorksheet("Employee Data");
      let header=["תז","שם","משפחה","תאריך לידה","מין","קופת חולים"]
let headerRow = worksheet.addRow(header);

  let x2=Object.keys(this.userP);
  let temp=[]
  for(let y of x2)
  {
    temp.push(this.userP[y])
  }
  worksheet.addRow(temp)
  

//set downloadable file name
let fname="Emp Data Sep 2020"

//add data and file name and download
workbook.xlsx.writeBuffer().then((data) => {
  let blob = new Blob([data], { type: 'application/vnd.openxmlformats-officedocument.spreadsheetml.sheet' });
  fs.saveAs(blob, fname+'-'+new Date().valueOf()+'.xlsx');
});
    }
}
