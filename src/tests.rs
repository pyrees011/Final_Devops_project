use super::*;

// Test for the index route
#[actix_web::test]
async fn test_index() {
    let response = index().await;
    assert_eq!(response, "Hello, world!");
}

// Test for the greet route
#[actix_web::test]
async fn test_greet() {
    let response = greet().await;
    assert_eq!(response, "Greetings from Rust!");
}
