import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import Child from '../models/child';

@Injectable({
  providedIn: 'root'
})
export class ChildrenService {

  constructor(public http:HttpClient) { }

childSer:Child=new Child(0,"",null);
   baseRouteUrl=`https://localhost:7291/api/Child`
 
  addChild(child:Child){
    // return this.http.post<object>(`${this.baseRouteUrl}/AddChild/?u=${child}`, child)
    return this.http.post<object>(`${this.baseRouteUrl}`, child)
  

  }
 
  getAllChildren(){
    return this.http.get<Child[]>(`${this.baseRouteUrl}`)
 
  }
}