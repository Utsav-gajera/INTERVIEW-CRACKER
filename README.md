# Interview Cracker - Frontend Application

A comprehensive platform for students to prepare for placement drives by accessing company-specific and college-specific interview questions.

## Features

### For Students
- Browse colleges and companies
- Access placement questions (MCQs and coding problems)
- Filter by year, difficulty, and search keywords
- View answers and solutions
- User-friendly interface with responsive design

### For Contributors
- Add new MCQs and coding questions
- Edit and manage their contributed content
- Associate questions with specific colleges, companies, and years
- Tag questions with difficulty levels

### For Admins
- Manage colleges and add new institutions
- Add and manage contributors
- Dashboard with platform statistics
- Oversee all platform activity

## Technology Stack

- **Framework**: ASP.NET Core 3.1 MVC
- **Authentication**: Cookie Authentication
- **Frontend**: HTML5, CSS3, Bootstrap 5, jQuery
- **Icons**: Font Awesome 6
- **Design**: Responsive design with modern UI/UX

## Demo Credentials

### Admin Access
- **Email**: admin@admin.com
- **Password**: admin123

### Contributor Access
- **Email**: contributor@test.com
- **Password**: test123

### Student Access
- **Email**: student@test.com
- **Password**: test123

## Project Structure

```
InterviewCracker/
├── Controllers/
│   ├── AccountController.cs      # Authentication & Login
│   ├── HomeController.cs         # Main student interface
│   ├── AdminController.cs        # Admin dashboard
│   └── ContributorController.cs  # Contributor interface
├── Models/
│   ├── User.cs                   # User model
│   ├── College.cs                # College model
│   ├── Company.cs                # Company model
│   ├── MCQ.cs                    # Multiple choice questions
│   ├── CodingQuestion.cs         # Coding problems
│   └── ViewModels.cs             # View models
├── Views/
│   ├── Account/                  # Login & Registration
│   ├── Home/                     # Student interface
│   ├── Admin/                    # Admin dashboard
│   ├── Contributor/              # Contributor interface
│   └── Shared/                   # Layout and shared views
└── wwwroot/
    ├── css/                      # Stylesheets
    └── js/                       # JavaScript files
```

## How to Run

1. **Prerequisites**:
   - .NET Core 3.1 SDK
   - Visual Studio 2019/2022 or VS Code
   - A web browser

2. **Clone or Extract** the project to your local machine

3. **Restore NuGet Packages**:
   ```bash
   dotnet restore
   ```

4. **Run the Application**:
   ```bash
   dotnet run
   ```

5. **Open Browser** and navigate to `https://localhost:5001` or `http://localhost:5000`

## Usage Flow

1. **Start at Login Page** - Use demo credentials or create a new student account
2. **Student Flow**:
   - Browse colleges on homepage
   - Select a college to view companies
   - Click on a company to see questions
   - Filter by year, difficulty, or search terms
3. **Admin Flow**:
   - Access admin dashboard
   - Manage colleges and users
   - Add new contributors
4. **Contributor Flow**:
   - Add new MCQs and coding questions
   - Edit existing contributions
   - Monitor approval status

## Key Features Implemented

### Authentication System
- Role-based access (Student, Contributor, Admin)
- Secure cookie authentication
- Registration for students only
- Admin-controlled contributor addition

### Responsive Design
- Mobile-first approach
- Bootstrap 5 framework
- Custom CSS with modern gradients
- Smooth animations and transitions

### User Interface
- Clean, modern design
- Intuitive navigation
- Search and filter functionality
- Interactive elements with hover effects

### Data Management
- In-memory data storage (for frontend demo)
- CRUD operations for all entities
- Proper data validation
- User role management

## Future Backend Integration

This frontend is designed to easily integrate with:
- Entity Framework Core for database operations
- SQL Server or other databases
- RESTful APIs
- Authentication systems (JWT, Identity)
- File upload for images
- Email services for notifications

## Browser Compatibility

- Chrome (recommended)
- Firefox
- Edge
- Mobile browsers


## Support

For any issues or questions about the frontend implementation, please check the code comments and structure. The application follows standard ASP.NET Core MVC patterns and is well-documented.

## Team members and individual contributions

CE112 - Lakahni Yug Rajeshbhai
CE026 - Gajera Utsav Vimalbhai

Project is done Via Pair-Programming Concept
