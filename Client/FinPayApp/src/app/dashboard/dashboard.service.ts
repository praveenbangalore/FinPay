import { BaseHttpService } from 'src/BaseHttp.Service';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable()
export class DashboardService extends BaseHttpService{

  constructor(private httpClient : HttpClient){
    super(httpClient);
    this.baseRoute ='dashboard'
}

stats():Observable<any>    {
    return this.get('get',this.COMMON_JSON_HEADER_REQUEST);
}
}
