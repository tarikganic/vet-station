import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OtherSignUpMethodsComponent } from './other-sign-up-methods.component';

describe('OtherSignUpMethodsComponent', () => {
  let component: OtherSignUpMethodsComponent;
  let fixture: ComponentFixture<OtherSignUpMethodsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [OtherSignUpMethodsComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(OtherSignUpMethodsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
