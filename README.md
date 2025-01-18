# QuickURL

QuickURL is a simple and efficient URL shortener built with .NET 8 and Docker support. It allows users to shorten long URLs into concise and shareable links while maintaining flexibility and scalability.

## Features

- **URL Shortening**: Transform long URLs into short, shareable links.
- **Statistics**: Track usage data for shortened URLs (if implemented).
- **Docker Support**: Seamless containerization for easy deployment.
- **Beginner Friendly**: Clean and simple code structure for easy understanding and contribution.

## Getting Started

Follow these steps to set up and run QuickURL on your local machine:

### Prerequisites

- [Docker](https://www.docker.com/) installed on your machine.
- [Git](https://git-scm.com/) for cloning the repository.
- .NET 8 SDK installed (optional, if running without Docker).

### Installation

1. **Clone the repository**:

   ```bash
   git clone https://github.com/yourusername/QuickURL.git
   cd QuickURL
   ```

2. **Build and run using Docker:**
   ```bash
   docker build -t quickurl .
   docker run -d -p 5000:5000 quickurl
   ```

**Running Locally without Docker (Optional)**

    1. Ensure you have the .NET 8 SDK installed.
    2. Run the application: `dotnet run`

## Usage

- **Shorten a URL**: Use the web interface to input a long URL and generate a shortened version.
- **Redirect**: Visit the shortened URL to be redirected to the original link.

## Contributing

We welcome contributions! To get started:

1. Fork the repository.
2. Create a new branch for your feature or bug fix.
3. Commit your changes.
4. Open a pull request.

Please ensure your code adheres to the existing style and includes tests if applicable.

## License

This project is licensed under the [MIT License](LICENSE).

## Contact

For questions or feedback, please feel free to create an issue or contact me at [your email or GitHub profile link].

---

Happy shortening! 🚀
