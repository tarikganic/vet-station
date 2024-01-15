import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VetStationHomePageComponent } from './vet-station-home-page.component';

describe('VetStationHomePageComponent', () => {
  let component: VetStationHomePageComponent;
  let fixture: ComponentFixture<VetStationHomePageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [VetStationHomePageComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(VetStationHomePageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
