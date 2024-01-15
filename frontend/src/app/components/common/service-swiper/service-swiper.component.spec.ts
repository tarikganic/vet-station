import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ServiceSwipperComponent } from './service-swiper.component';

describe('ServiceSwipperComponent', () => {
  let component: ServiceSwipperComponent;
  let fixture: ComponentFixture<ServiceSwipperComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ServiceSwipperComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ServiceSwipperComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
