import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { HttpResponse } from '@angular/common/http';
import { DashboardService } from './dashboard.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {

  username = '';
  statistics = {
    totalInvoices :0,
    totalPayment:0,
    paymentFailed:0,
    totalResponse:0
  }
  constructor(private builder :FormBuilder,
    private router : Router, private dashboardService : DashboardService) { }

  ngOnInit() {
    this.username =  localStorage.getItem('username');
    
    this.dashboardService.stats().subscribe((result : any ) =>{   
      this.statistics = result;
    });

}
}
