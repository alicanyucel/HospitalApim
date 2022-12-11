import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { DoctorModel } from '../models/doctor';
import { ApiService } from '../Shared/ApiService';

@Component({
  selector: 'app-doktor',
  templateUrl: './doctor.component.html',
  styleUrls: ['./doktor.component.css']
})
export class DoktorComponent implements OnInit {

  formvalues!: FormGroup;
  personmodelobject: DoctorModel = new DoctorModel();
  doctordata!: any;
  constructor(private formbuilder: FormBuilder,
    private api: ApiService) { }

  ngOnInit(): void {
    this.formvalues = this.formbuilder.group({
      doctortc: [''],
      doctorname: [''],
      doctorlastname: ['']
    })
    this.getAllDoctor();
  }
  postDoctorDetay() {
    this.personmodelobject.doctortc = this.formvalues.value.doctortc;
    this.personmodelobject.doctorname = this.formvalues.value.doctorname;
    this.personmodelobject.doctorlastname = this.formvalues.value.doctorlastname;

    this.api.PostDoctor(this.personmodelobject)
      .subscribe(res => {
        console.log(res);
        alert("doktor eklendi");

        this.formvalues.reset();
        this.getAllDoctor();
      })
  }
  getAllDoctor() {
    this.api.GetDoctor()
      .subscribe(res => {
        this.doctordata = res;
      })
  }
}
