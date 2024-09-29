# Fibonacci API
The **Fibonacci API** is designed to find a Fibonacci sequence number by its index.

---

## Getting Started

Follow the instructions below to run the API.

### Prerequisites

Ensure you have the following installed:

- [Docker](https://www.docker.com/get-started)

### How to Run

1. **Clone the Repository**

   Clone the main branch of the repository to your local machine:

   ```bash
   git clone git@github.com:arnask/FibonacciApi.git
   ```

2. **Ensure Docker is Installed and Running**

   Make sure Docker is properly installed and running on your machine.

3. **Navigate to the Project Directory**

   Open PowerShell (or any terminal of your choice) and navigate to the root directory of the project, where the `docker-compose.yml` file is located:

   ```bash
   cd path-to-the-project/FibonacciApi
   ```

4. **Run the API with Docker Compose**

   Start the application by running the following command in PowerShell:

   ```bash
   docker-compose up
   ```

5. **Access the API via Swagger UI**

   Once the containers are up and running, a browser window with Swagger UI should open automatically. If it doesn't, manually open your browser and navigate to the following URL:

   ```
   http://localhost:8000/swagger/index.html
   ```

   This will give you access to the API documentation and allow you to test the endpoint directly from the browser.

---   


## Containerization

For containerization, I would select Docker, because it is the most popular, and offers many prebuilt images, such as databases, which simplifies setup and deployment. I also have the most experience with this tool.

---

## CI / CD Pipeline

For CI/CD, I would choose Azure DevOps, because it is a Microsoft product with native support for .NET applications.  Additionally, I have significant experience using this platform, making it the optimal choice for this project.

---

### Continuous Integration  Process

1. The main branch is disabled for direct pushes. Instead, developers push new code to a feature branch.
2. The CI pipeline is triggered automatically when new code is pushed.
3. The pipeline installs dependencies, compiles the code, and packages the application.
4. Automated tests are run to validate the new code.
5. The code is analyzed to ensure it meets quality standards.
6. The build artifact or Docker image is deployed to the development environment for testing.
7. After two approvals from other developers, the feature branch can be merged into the main branch.

---

### Continuous Deployment Process

The CD pipeline would automate deployment of the application. I would recommend to have several environments:
- **Development**:  
  Deployed from the feature branch after each build. This environment would be used for testing new features, before merging them into the main branch.
- **Test**:  
  Deployed after merging into the main branch. In this environment would run automated tests, including unit and integration tests.
- **Stage**:  
  Stores the latest stable version of the application, before being deployed to production.
- **Production**:  
  Hosts the live version of the application. This is where users access and interact with the app.

These environments would provide isolated spaces for testing and deploying features, ensuring fewer bugs reach production.

---

## Monitoring and Logging

### Monitoring: Azure Application Insights

For monitoring, I would prefer to use Azure Application Insights to track key metrics for maintaining the application’s performance:

- **Response Time**: Monitors how long the application takes to process requests.
- **Request Rate**: Measures the application's load and performance under varying levels of user activity.
- **Uptime & Downtime**: Tracks application availability and reliability.
- **Error Rate**: Tracks the percentage of requests resulting in errors compared to total requests.

### Logging

For logging, I would prefer to use Serilog, for its structured logging capabilities, making it easier to find specific logs and detect problems faster. It supports various sinks like file storage and cloud services (e.g., Azure Application Insights). Log entries will include:

- **Log Level**
- **Timestamp**
- **Request ID**
- **Host Name**
- **Stack Trace**

---

## Scaling

To ensure the system can handle high traffic and provide reliable uptime, I would suggest horizontal scaling and distributed caching. For horizontal scaling I would add additional instances of the service to distribute the load and minimize downtime in case one instance fails. For distributed caching I would prefer to use Redis, to store more Fibonacci numbers and improve performance by distributing cache across multiple nodes.

---
