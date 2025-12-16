# The Money Example
This contains the tests and code examples from the first part
of the Book. I decided to code them in Rust to have some fun
with exploring the idiosyncraties of the Rust language while
implementing a basic TDD approach.

This is very easy as a testing framework is included in the
core language tooling and unit tests are usually defined
*inline* within the implementation files.

## Progress

As in the book, we track progress in a todo list here.

- [ ] `$5` + `10 CHF` = `$10` if rate is 2:1
- [x] `$5 * 2` = `$10`
- [ ] Make `amount` private
- [x] Dollar side effects?
- [ ] Money rounding?
- [ ] `equals()`

## Using Rust

### Equality and Hashing 

In Rust, we can `derive(PartialEq, Eq, Hash) ` to derive the traits for both 
equality and hashing if all fields of our structure implement them.
See 
- https://doc.rust-lang.org/std/hash/trait.Hash.html#hash-and-eq
- https://doc.rust-lang.org/std/cmp/trait.Eq.html