import { Component } from '@angular/core';
import { ImageCarouselComponent } from '../common/image-carousel/image-carousel.component';
import { ServiceSwipperComponent } from '../common/service-swiper/service-swiper.component';
import { AboutUsFooterComponent } from './about-us-footer/about-us-footer.component';
@Component({
  selector: 'app-vet-station-home-page',
  standalone: true,
  imports: [ImageCarouselComponent, ServiceSwipperComponent, AboutUsFooterComponent],
  templateUrl: './vet-station-home-page.component.html',
  styleUrl: './vet-station-home-page.component.css'
})
export class VetStationHomePageComponent {

}
