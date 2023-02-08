import Child from "./child";

export default class People{
    constructor(public Id:number,public Tz:string,public Fname:string,public Lname:string,
        public DateOfBirdth:Date,public Min:string,public Hmo:string,
        
       
    )
    
    {  }
    saveInStorage(user) {
        localStorage.setItem("currentUser", JSON.stringify(user));
      }
      getFromStorage() {
        let u = localStorage.getItem("currentUser");
        if (!u)
          return null;
        return JSON.parse(u);
      }
      removeFromStorage() {
        localStorage.removeItem("currentUser");
      }
}