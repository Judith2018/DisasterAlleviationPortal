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
