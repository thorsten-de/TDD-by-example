mod money {
    #[derive(PartialEq, Eq, Debug)]
    pub struct Dollar {
        amount: i32
    }

    impl Dollar {
        pub fn new(amount: i32) -> Dollar {
            Dollar { amount }
        }

        pub fn times(&self, multiplier: i32) -> Dollar {
            Dollar::new(self.amount * multiplier)
        }
    }
    #[derive(PartialEq, Eq, Debug)]
    pub struct Franc {
        amount: i32
    }

    impl Franc {
        pub fn new(amount: i32) -> Franc {
            Franc { amount }
        }

        pub fn times(&self, multiplier: i32) -> Franc {
            Franc::new(self.amount * multiplier)
        }
    }

    impl PartialEq<Dollar> for Franc {
        fn eq(&self, _other: &Dollar) -> bool {
            false
        }
    }

}



#[cfg(test)]
mod tests {
    use super::money::*;
    
    #[test]
    fn test_multiplication() {
        let five = Dollar::new(5);
        assert_eq!(Dollar::new(10), five.times(2));
        assert_eq!(Dollar::new(15), five.times(3));
    }

    fn test_franc_multiplication() {
        let five = Franc::new(5);
        assert_eq!(Franc::new(10), five.times(2));
        assert_eq!(Franc::new(15), five.times(3));
    }

    #[test]
    fn test_equality() {
        assert_eq!(Dollar::new(5), Dollar::new(5));
        assert_ne!(Dollar::new(5), Dollar::new(10));

        assert_eq!(Franc::new(5), Franc::new(5));
        assert_ne!(Franc::new(5), Franc::new(10));

        assert_ne!(Franc::new(5), Dollar::new(5));
    }
}
