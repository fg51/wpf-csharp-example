#ifndef D_WRAPPER_H
#define D_WRAPPER_H

#ifdef __cplusplus
#include <cstdint>

#define DLLEXPORT extern "C" __declspec(dllexport)
#else
#define DLLEXPORT extern "C" __declspec(dllexport)
#endif

DLLEXPORT void wrapper_func(const int32_t xs[10], int32_t ys[10]);

#endif
