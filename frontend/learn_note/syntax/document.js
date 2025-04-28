// Strict equality (===)
// 1. The strict equality (===) operator checks whether its two operands are equal, returning a Boolean result.
// Unlike the equality operator, the strict equality operator always considers operands of different types to be different.

// 2. Description
// If the operands are of different types, return false.
// If both operands are objects, return true only if they refer to the same object.
// If both operands are null or both operands are undefined, return true.
// If either operand is NaN, return false.
// Otherwise, compare the two operand's values:
//     Numbers must have the same numeric values. +0 and -0 are considered to be the same value.
//     Strings must have the same characters in the same order.
//     Booleans must be both true or both false.

import { strict_equality } from '../../src/practice/syntax/strict_equality';

// Equality (==)
// https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/Equality (nhiều case và dk hơn so với strict equality)
// https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Equality_comparisons_and_sameness#comparing_equality_methods
