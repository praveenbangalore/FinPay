import { Component, OnInit } from '@angular/core';
import { TransactionsService } from './transactions.service';

@Component({
  selector: 'app-transactions',
  templateUrl: './transactions.component.html',
  styleUrls: ['./transactions.component.scss']
})

export class TransactionsComponent implements OnInit {

  public transactions: Transactions[];
  constructor(private transactionsService:TransactionsService) { 

  }

  ngOnInit() {

    this.transactionsService.getTransactions().subscribe((result : any ) =>{
      console.log("Got data fro transactions");

       this.transactions = result; 
      
    });
  }

}

interface Transactions {
  fromAccount: string;
  toAccount: number;
  transactionId: number;
  amount: string;
}
