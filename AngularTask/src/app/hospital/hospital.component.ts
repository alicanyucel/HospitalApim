import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Hospital } from '../models/hospital';
import { ApiService } from '../Shared/ApiService';

@Component({
  selector: 'app-hospital',
  templateUrl: './hospital.component.html',
  styleUrls: ['./hospital.component.css']
})
export class HospitalComponent implements OnInit {

  formvalues!: FormGroup;
  hospitalmodelobject: Hospital = new Hospital();
  hospitaldata!: any;

  constructor(private formbuilder: FormBuilder,private api:ApiService) { }
  ngOnInit(): void {
    this.formvalues=this.formbuilder.group({
      name !: [''],
      adress !: [''],

    })
    this.getHospital();
  }
  postHospitalDetay() {
    this.hospitalmodelobject.name= this.formvalues.value.name;
    this.hospitalmodelobject.adress = this.formvalues.value.adress;
    this.api.postHospital(this.hospitalmodelobject)
      .subscribe(res => {
        console.log(res);
        alert("hastane eklendi");
        this.formvalues.reset();
        this.getHospital();
      })
  }
  getHospital() {
    this.api.getAll()
      .subscribe(res => {
        this.hospitaldata = res;
      })
    }
  }
