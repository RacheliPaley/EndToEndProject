import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import People from '../models/user';

@Injectable({
  providedIn: 'root'
})
export class StateService {
  // state$ = new BehaviorSubject<People>(null);
}
