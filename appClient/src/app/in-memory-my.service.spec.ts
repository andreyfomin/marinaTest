import { TestBed, inject } from '@angular/core/testing';

import { InMemoryMyService } from './in-memory-my.service';

describe('InMemoryMyService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [InMemoryMyService]
    });
  });

  it('should be created', inject([InMemoryMyService], (service: InMemoryMyService) => {
    expect(service).toBeTruthy();
  }));
});
