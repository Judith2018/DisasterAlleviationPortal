# DisasterAlleviationPortal
This is a secure, user-friendly web application built with ASP.NET Core MVC and Azure SQL. It supports disaster relief efforts by allowing users to register, log in, volunteer, donate, and report incidents. The project demonstrates full-stack development, database integration, and CI/CD pipeline setup using Azure DevOps.

Technologies Used ASP.NET Core MVC for building the web application

Azure SQL Database for storing user, donation, and disaster report data

Entity Framework Core for managing database schema and migrations

ASP.NET Identity for secure authentication and user management

Azure DevOps for CI/CD pipeline setup and Git repository management

GitHub for source control and version tracking

Visual Studio 2022 as the development environment

Azure Web App for hosting the live application

User Features Registration and Login Users must register before logging in. The registration form includes full name, email, password, and confirm password fields. Passwords must meet strong security requirements. Once registered, users can log in securely using ASP.NET Identity.

Volunteer Sign-Up Logged-in users can register as volunteers by submitting their name, contact details, preferred volunteering date, and a timestamp (automatically recorded). This information is stored in the Azure SQL database.

Donations Users can submit donations by specifying their name, donation type (e.g., food, clothing, money), quantity or amount, and a timestamp. All donations are tracked in the database.

Disaster Reports Authorized users can log disaster incidents by providing the location, description, severity level, and date reported. These reports are stored for administrative review and response coordination.

Developer Setup Clone the repository:

Code git clone https://github.com/Judith2018/DisasterAlleviationPortal.git Update the connection string in appsettings.json with your Azure SQL credentials.

Run Entity Framework migrations:

Code dotnet ef migrations add InitialCreate dotnet ef database update Launch the application using Visual Studio (IIS Express or Kestrel).

Azure DevOps Pipeline A CI pipeline is configured using azure-pipelines.yml. It includes build and publish steps. Deployment was attempted using a service connection with Managed Identity, but was blocked due to institutional Microsoft Entra permissions. This issue is documented in the submission.

Screenshots and Evidence Summary This section provides visual and functional evidence of the Disaster Alleviation Portal, including user interactions, database integration, and Azure resource setup.

Home Page Screenshot: Disaster Alleviation Portal landing page Description: Welcoming interface with navigation links to Home, Register, Login, Volunteer, Donation, Disaster Report, and Dashboard. Includes clear calls to action for volunteers, donors, and reporters.
<img width="1500" height="672" alt="image" src="https://github.com/user-attachments/assets/68cde72f-e8aa-4b07-b538-f2cdae18ddf5" />

Registration Flow Screenshot: Registration form and confirmation Description: User enters full name, email, and password. Upon submission, a green confirmation message confirms successful registration.
<img width="913" height="605" alt="image" src="https://github.com/user-attachments/assets/aee81f50-c051-4200-9915-2cea5b13a881" />

Login Flow Screenshot: Login form and welcome message Description: Registered users log in using email and password. A welcome message confirms successful authentication.
<img width="847" height="348" alt="image" src="https://github.com/user-attachments/assets/0c30bf39-65f9-448a-8a4d-2a7bfa5cae71" />
<img width="987" height="171" alt="image" src="https://github.com/user-attachments/assets/cb3527f6-3c6a-4ee8-9e6f-ab549cd69632" />

Volunteer Sign-Up Screenshot: Volunteer form and confirmation Description: Users submit their name, contact number, availability, and preferred volunteering date. A confirmation message acknowledges their commitment.
<img width="1500" height="482" alt="image" src="https://github.com/user-attachments/assets/e1a7b2f9-0eaa-443b-8a08-3156c5108951" />

Donation Submission Screenshot: Donation form and confirmation Description: Users enter donor name, resource type, and quantity. A thank-you message confirms the donation was received.
<img width="1500" height="414" alt="image" src="https://github.com/user-attachments/assets/4ca92181-0955-4af5-8214-8db2c4c8c86a" />

Disaster Report Submission Screenshot: Disaster report form Description: Users report incidents by entering location, description, and severity level. This data is stored in the DisasterReports table.
<img width="1500" height="482" alt="image" src="https://github.com/user-attachments/assets/594fed34-b19a-4d9a-9b9c-7e786c95dfe1" />

Azure SQL Database – DisasterReports Table Screenshot: Query results from DisasterReports Description: Shows stored disaster report data including location, description, and severity level. Confirms backend integration.
<img width="1500" height="610" alt="image" src="https://github.com/user-attachments/assets/29afdc5a-e386-4ad3-8988-f04b5a35e0f7" />

Azure SQL Database – Volunteers Table Screenshot: Query results from Volunteers Description: Displays volunteer entries with full name, contact number, availability, and assigned disaster ID.
<img width="1500" height="655" alt="image" src="https://github.com/user-attachments/assets/8d7addd6-e01e-42e2-99e0-8a44fbaf2629" />

Azure SQL Database – Donations Table Screenshot: Query results from Donations Description: Shows donation records including donor name, resource type, and quantity.
<img width="1500" height="616" alt="image" src="https://github.com/user-attachments/assets/9cd337eb-f70b-4e13-8591-dc4e9f32c734" />

Azure Resource Overview Screenshot: Azure portal resource list Description: Displays active resources including SQL database, App Service, App Service Plan, and Storage Account. Confirms cloud deployment setup.
<img width="1500" height="385" alt="image" src="https://github.com/user-attachments/assets/27fc6e57-41e9-48d2-a670-5a26f1ae2206" />

Azure DevOps Pipeline Screenshot: Pipeline setup and run status Description: Shows pipeline creation and execution attempt. Although deployment was blocked due to Entra permissions, the CI setup is complete and documented.

Submission Evidence GitHub repository with commit history

Azure DevOps repository and pipeline setup

YAML pipeline file

Screenshots of pipeline run and service connection attempt

Manual deployment or explanation of deployment block

Notes Due to institutional restrictions, automatic service connection and deployment via Azure DevOps were not possible. Manual deployment or documentation of the issue is included in the submission. All core features are implemented and tested, and the project demonstrates a complete understanding of ASP.NET MVC, database integration, and CI/CD workflows.

Part 3 Overview – Testing and CI/CD
In this phase, I moved beyond building features and focused on validating them through structured testing. I implemented unit tests to verify core logic, integration tests to confirm controller-to-database flow, and performance tests to measure how the app handles load. I also automated UI testing using Selenium and configured a CI/CD pipeline in Azure DevOps to simulate professional deployment workflows.

Here’s a breakdown of what I completed:

Unit Testing: I created MSTest and xUnit projects to validate methods like login credential checks and donation input. These tests helped catch logic errors early and confirmed that my business rules were working as expected.
<img width="1912" height="476" alt="Logic_screenshot" src="https://github.com/user-attachments/assets/df8eb5dc-edbd-4474-9d76-fea39c761773" />
<img width="1878" height="857" alt="donation_test" src="https://github.com/user-attachments/assets/45547ec0-7dea-4ee0-b882-0544ddd3ffc1" />
<img width="1918" height="882" alt="loginValidation_test" src="https://github.com/user-attachments/assets/53ccaf94-f8ed-4f0a-8fd4-aac2cd32cd3b" />
<img width="1831" height="438" alt="loginValidator cs" src="https://github.com/user-attachments/assets/da03552e-3aa1-4900-8ace-04be3ac53426" />
<img width="1918" height="812" alt="loginValidationTest cs" src="https://github.com/user-attachments/assets/761241af-7619-4313-8d6e-c759c7b2b433" />
<img width="1916" height="361" alt="DonationService cs" src="https://github.com/user-attachments/assets/103a9ce3-e4ab-4d1e-aaf0-bac7832b1e4b" />
<img width="1908" height="772" alt="DonationServiceTest cs" src="https://github.com/user-attachments/assets/bf5adf33-9427-4d39-a4fb-7b2f5eb9e8ef" />

Integration Testing: I used EF Core’s InMemoryDatabase to simulate real interactions between controllers and the data layer. This allowed me to test routing, data flow, and controller behavior without relying on a live SQL server.
<img width="1895" height="863" alt="integration_test_failed" src="https://github.com/user-attachments/assets/0b998e08-8fea-4e58-8fe1-b7a26e8337f5" />

Load and Stress Testing: I used Apache JMeter to simulate multiple users accessing the portal. I recorded metrics like response time, throughput, and error rates to evaluate how the system performs under pressure.
<img width="1902" height="651" alt="Program_csStructure" src="https://github.com/user-attachments/assets/da01ecf7-3088-4e10-8610-e30d746edda7" />
<img width="1508" height="855" alt="summaryReport" src="https://github.com/user-attachments/assets/cc8c285f-e108-4529-b8c1-db42689db217" />

Automated UI Testing: I wrote Selenium tests to automate browser interactions such as logging in and submitting forms. These tests ran both locally and in headless mode on Azure build agents, ensuring compatibility with CI pipelines.
<img width="1918" height="986" alt="login_to_dashboard_test" src="https://github.com/user-attachments/assets/ad693f69-0b94-4ab7-860f-8a7e7d25df24" />

CI/CD Pipeline: I configured an Azure DevOps pipeline that builds, tests, and (where permitted) deploys the application. This setup reflects real-world development practices and ensures that all tests run automatically before deployment.
<img width="1917" height="1012" alt="Pipeline" src="https://github.com/user-attachments/assets/3b85a018-e8f1-4c32-9fc0-8d6eb099ade8" />
<img width="1918" height="862" alt="pipeline2" src="https://github.com/user-attachments/assets/1f05dc3d-cc5c-48bb-a976-db20b62e4a0b" />

Final Report: I compiled all testing evidence—including screenshots, code snippets, and performance summaries—into a structured report. I also included usability feedback to demonstrate how real users interact with the portal.

This phase demonstrates my ability to test, validate, and deliver software professionally. It shows that I understand not just how to build an application, but how to ensure it’s robust, scalable, and ready for deployment.
