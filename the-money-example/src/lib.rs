#[derive(Debug)]
struct Dollar {
    amount: i32
}

impl PartialEq for Dollar {
    fn eq(&self, other: &Self) -> bool {
        true
    }
}

impl Eq for Dollar {}

impl Dollar {
    fn new(amount: i32) -> Dollar {
        Dollar { amount }
    }

    fn times(&self, multiplier: i32) -> Dollar {
        Dollar::new(self.amount * multiplier)
    }
}


#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn test_multiplication() {
        let five = Dollar::new(5);

        let product: Dollar = five.times(2);
        assert_eq!(10, product.amount);

        let product: Dollar = five.times(3);
        assert_eq!(15, product.amount);
    }

    #[test]
    fn test_equality() {
        assert_eq!(Dollar::new(5), Dollar::new(5));
        assert_ne!(Dollar::new(5), Dollar::new(10));
    }
}
