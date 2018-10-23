import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddressEntryComponent } from './address-entry.component';

describe('AddressEntryComponent', () => {
  let component: AddressEntryComponent;
  let fixture: ComponentFixture<AddressEntryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddressEntryComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddressEntryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
