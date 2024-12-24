# Use the official Rust image as the base
FROM rust:latest

# Set the working directory
WORKDIR /app

# Copy the Cargo.toml and lock file
COPY Cargo.toml Cargo.lock ./

# Create a new empty Rust project
RUN cargo new --bin app
WORKDIR /app

# Copy the source code
COPY ./src ./src

# Build the application
RUN cargo build --release

# Expose the application port
EXPOSE 8080

# Run the binary
CMD ["./target/release/rust-backend"]
