# Recipe App

A full-stack application for managing your recipe collection with a modern, user-friendly interface and real-time updates.

## Features

- Add recipes with titles, ingredients, and instructions
- View detailed recipe information
- Edit or delete existing recipes
- Search and filter recipes by name or ingredients
- Responsive design that works on all devices
- Real-time updates for recipe changes

## Tech Stack

### Frontend
- React 18
- Material-UI (MUI) v5 for components and styling
- Framer Motion for animations
- Axios for API calls

### Backend
- .NET 8.0
- ASP.NET Core Web API
- Entity Framework Core with PostgreSQL
- Swagger/OpenAPI for API documentation

## Prerequisites

- Node.js (v16 or higher)
- .NET 8.0 SDK
- PostgreSQL database

## Getting Started

### Backend Setup

1. Navigate to the backend directory:
   ```bash
   cd ServerSide
   ```

2. Install the .NET dependencies:
   ```bash
   dotnet restore
   ```

3. Update the database connection string in `appsettings.json` if needed

4. Run the migrations:
   ```bash
   dotnet ef database update
   ```

5. Start the backend server:
   ```bash
   dotnet run
   ```

The API will be available at `http://localhost:5005`

### Frontend Setup

1. Navigate to the frontend directory:
   ```bash
   cd ClientSide
   ```

2. Install dependencies:
   ```bash
   npm install
   ```

3. Start the development server:
   ```bash
   npm start
   ```

The application will open in your default browser at `http://localhost:3000`

## Project Structure

```
Recipe App/
├── ServerSide/             # .NET backend
│   ├── Controllers/        # API endpoints
│   ├── Models/             # Data models and DB context
│   └── Properties/         # Launch settings
├── ClientSide/             # React frontend
│   ├── public/             # Static assets
│   └── src/                # React components and logic
│       ├── AddRecipeForm.js
│       ├── RecipeList.js
│       ├── RecipeDetails.js
│       └── App.js
```

## API Endpoints

- `GET /api/Recipes` - Get all recipes
- `POST /api/Recipes` - Add a new recipe
- `PUT /api/Recipes/{id}` - Update a recipe
- `DELETE /api/Recipes/{id}` - Delete a recipe

## Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## License

This project is licensed under the MIT License - see the LICENSE file for details.
