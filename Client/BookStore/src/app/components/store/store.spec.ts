import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Store } from './store';

describe('Store', () => {
  let component: Store;
  let fixture: ComponentFixture<Store>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [Store]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Store);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
