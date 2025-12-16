mod money {
    #[derive(PartialEq, Eq, Debug)]
    pub struct Dollar {
        amount: i32,
        currency: Currency
    }

    impl Dollar {
        pub fn times(&self, multiplier: i32) -> Dollar {
            Dollar { amount: self.amount * multiplier }
        }

        pub fn currency(&self) -> &Currency {
            &self.currency
        }
    }

    impl PartialEq<Franc> for Dollar {
        fn eq(&self, _other: &Franc) -> bool {
            false
        }
    }

    #[derive(PartialEq, Eq, Debug)]
    pub struct Franc {
        amount: i32,
        currency: Currency
    }

    impl Franc {
        pub fn times(&self, multiplier: i32) -> Franc {
            Franc { amount: self.amount * multiplier }
        }

        pub fn currency(&self) -> &Currency {
            &self.currency
        }
    }

    impl PartialEq<Dollar> for Franc {
        fn eq(&self, _other: &Dollar) -> bool {
            false
        }
    }

    pub struct Money;
    impl Money{
        pub fn dollar(amount: i32) -> Dollar {
            Dollar { amount }
        }

        pub fn franc(amount: i32) -> Franc {
            Franc { amount }
        }

    }

    type Currency = String;
}


#[cfg(test)]
mod tests {
    use super::money::*;

    #[test]
    fn test_multiplication() {
        let five = Money::dollar(5);
        assert_eq!(Money::dollar(10), five.times(2));
        assert_eq!(Money::dollar(15), five.times(3));
    }

    #[test]
    fn test_franc_multiplication() {
        let five = Money::franc(5);
        assert_eq!(Money::franc(10), five.times(2));
        assert_eq!(Money::franc(15), five.times(3));
    }

    #[test]
    fn test_equality() {
        assert_eq!(Money::dollar(5), Money::dollar(5));
        assert_ne!(Money::dollar(5), Money::dollar(10));

        assert_eq!(Money::franc(5), Money::franc(5));
        assert_ne!(Money::franc(5), Money::franc(10));

        assert_ne!(Money::franc(5), Money::dollar(5));
        assert_ne!(Money::dollar(5), Money::franc(5));
    }

    #[test]
    fn test_currency() {
        assert_eq!("USD", Money::dollar(1).currency());
        assert_eq!("CHF", Money::franc(1).currency());
    }
}
