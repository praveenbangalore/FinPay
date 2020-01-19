import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { InvoiceService } from './invoice.service';

@Component({
  selector: 'app-invoice',
  templateUrl: './invoice.component.html',
  styleUrls: ['./invoice.component.scss']
})
export class InvoiceComponent implements OnInit {

  invoiceForm : FormGroup;
  errorMessage = '';
  
  constructor(private builder :FormBuilder,
    private router : Router,
    private invoiceService : InvoiceService) { 

    }

  ngOnInit() {
    this.invoiceForm = this.builder.group({
      invoiceNumber :['',Validators.required],
      issueDate :['',Validators.required],
      partner :['',Validators.required],
      contact :['',Validators.required],
      email:['',Validators.email],
      id:['',Validators.email]
    });
  }
  
  onGenerate()  {
    console.log('generate');

    // if(!this.invoiceForm.valid)
    //     return;

      // this.errorMessage ='';

      this.invoiceService.create(this.invoiceForm.value).subscribe((result : any ) =>{
       
        
        alert("Invoice raised successfully");
        
      });

  }
  

}
