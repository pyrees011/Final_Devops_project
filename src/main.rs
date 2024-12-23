use actix_web::{get, App, HttpServer, Responder};

#[get("/")]
async fn index() -> impl Responder {
    "Hello, world!"
}

#[get("/greet")]
async fn greet() -> impl Responder {
    "Greetings from Rust!"
}

#[actix_web::main]
async fn main() -> std::io::Result<()> {
    HttpServer::new(|| {
        App::new()
            .service(index)
            .service(greet)
    })
    .bind("0.0.0.0:8080")?
    .run()
    .await
}

#[cfg(test)]
mod tests {
    use super::*;
    use actix_web::{test, App};

    #[actix_web::test]
    async fn test_index() {
        let app = test::init_service(App::new().service(index)).await;
        let req = test::TestRequest::get().uri("/").to_request();
        let resp = test::call_and_read_body(&app, req).await;
        assert_eq!(resp, "Hello, world!");
    }

    #[actix_web::test]
    async fn test_greet() {
        let app = test::init_service(App::new().service(greet)).await;
        let req = test::TestRequest::get().uri("/greet").to_request();
        let resp = test::call_and_read_body(&app, req).await;
        assert_eq!(resp, "Greetings from Rust!");
    }
}
