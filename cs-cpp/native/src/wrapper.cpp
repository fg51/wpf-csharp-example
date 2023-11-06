#include "wrapper.h"

#include "person.h"
// #include <iostream>

DLLEXPORT void add(const int32_t xs[10], int32_t ys[10]) {
  // const int32_t xxs[10]{
  //     0,
  // };
  //  int32_t ys[10]{
  //     0,
  // };

  // std::cout << xs[0] << std::endl;
  Person p{};
  p.add(xs, ys);
  // std::cout << ys[0] << std::endl;
  //  return 10;
}
