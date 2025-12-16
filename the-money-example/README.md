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
- [x] Make `amount` private
- [x] Dollar side effects?
- [ ] Money rounding?
- [x] `equals()`
- [ ] HashCode?
- [x] `5 CHF * 2` = `10 CHF`
- [x] Dollar/Franc duplication
- [x] <s>Equal null</s> is not idiomatic in safe Rust code
- [ ] Equal objects 
- [x] <s>Common equals</s> is not needed: Rust offers traits for this
- [x] Common times
- [x] Compare Francs with Dollars (and vice versa)
- [x] Currency?
- [ ] Remove test duplicates for Franc equality and multiplication

## Using Rust

### Equality and Hashing 

In Rust, we can `derive(PartialEq, Eq, Hash) ` to derive the traits for both 
equality and hashing if all fields of our structure implement them.
See 
- https://doc.rust-lang.org/std/hash/trait.Hash.html#hash-and-eq
- https://doc.rust-lang.org/std/cmp/trait.Eq.html

### Encapsulation with Modules

Encapsulation and Information Hiding in Rust is done with 
[Modules](https://doc.rust-lang.org/rust-by-example/mod.html). These
constrain visibility on different levels:

- Structs
- Fields inside structs
- Methods implemented on Structs

### No class inheritance in Rust

There is no inheritance on the struct level in Rust, so we skip chapter 6 about moving equals to
a `Money`, a common subclass for `Dollar` and `Franc`. There is no need to extract equals, as Rust
has defined the behavior of equality in the `Eq` and `PartialEq` traits. We derive them for each 
of our two structs, so there's nothing to gain for us at the moment.

Comparing `Dollar` and `Franc` structs is possible with implementing `PartialEq<Dollar> for Franc` and
vice versa. This differs from the books implementation based on a superclass implementing equals for 
both cases directly.

### Chapter 8 - Using Money superclass in test

We must adapt to Rust a bit in this part, as it is clumsy to define and use a trait for the two 
money structs. This includes dynamic dispatch, and will be overkill to introduce as we want to
consolidate into only one struct anyway.

Therefore, we try to unify `Dollar` and `Franc` to the point of having identical implementions.
A *diffentiator* is needed to prevent that equality will mix up different currencies, and with
that in mind we follow chapter 9.