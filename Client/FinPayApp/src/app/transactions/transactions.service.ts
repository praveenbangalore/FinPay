import { BaseHttpService } from 'src/BaseHttp.Service';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable()
export class TransactionsService extends BaseHttpService{

  

  constructor(private httpClient : HttpClient){
    super(httpClient);
    this.baseRoute ='transactions'
}

getTransactions():Observable<any>    {
    return this.get('get',this.COMMON_JSON_HEADER_REQUEST);
}


}
