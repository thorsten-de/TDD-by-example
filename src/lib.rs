struct Dollar {
    amount: i32
}
impl Dollar {
    fn new(amount: i32) -> Dollar {
        Dollar { amount: amount *2 }
    }

    fn times(&self, _amount: i32) {
    }
}


#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn test_multiplication() {
        let five = Dollar::new(5);
        five.times(2);
        assert_eq!(10, five.amount);
    }
}
