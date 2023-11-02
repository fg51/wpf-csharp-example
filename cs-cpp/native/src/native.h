#ifndef D_NATIVE_H
#define D_NATIVE_H

#ifdef __cplusplus
#include <cstdint>

#define DLLEXPORT extern "C" __declspec(dllexport)
#else
#define DLLEXPORT extern "C" __declspec(dllexport)
#endif

DLLEXPORT int32_t add();
// extern "C" fn add(left: i32, right: i32) -> i32 {
#endif
