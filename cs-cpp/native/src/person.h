#ifndef D_PERSON_H
#define D_PERSON_H

#include <cstdint>

class Person {
public:
  Person();
  // Person(Person &&) = default;
  // Person(const Person &) = default;
  // Person &operator=(Person &&) = default;
  // Person &operator=(const Person &) = default;
  ~Person();

  void add(const int32_t xs[10], int32_t ys[]);

private:
};

#endif
