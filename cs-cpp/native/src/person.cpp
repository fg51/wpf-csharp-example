#include "person.h"
#include <iostream>

Person::Person() {}

Person::~Person() {}

void Person::add(const int32_t xs[10], int32_t ys[10]) {
  for (auto i = 0; i != 10; ++i) {
    ys[i] = xs[i] + 1;
  }
}
