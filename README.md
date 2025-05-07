# Movie Wishlist

A full-stack application for managing your movie watchlist with a modern, animated UI and real-time updates.

## Features

- Add movies to your watchlist with titles and notes
- Rate movies using a 5-star rating system
- Mark movies as watched/unwatched
- Sort movies by newest or oldest first
- Animated movie posters for visual appeal
- Responsive design that works on all devices
- Real-time notifications for all actions
- Dark theme with gold accents

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
   cd backend
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
   cd my-app
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
Movie Wishlist/
├── backend/                 # .NET backend
│   ├── Controllers/        # API endpoints
│   ├── Models/            # Data models and DB context
│   └── Properties/        # Launch settings
├── my-app/                 # React frontend
│   ├── public/           # Static assets
│   └── src/             # React components and logic
│       ├── AddMovieForm.js
│       ├── MovieList.js
│       └── App.js
```

## API Endpoints

- `GET /api/Movies` - Get all movies
- `POST /api/Movies` - Add a new movie
- `PUT /api/Movies/{id}` - Update a movie (rating, watched status)
- `DELETE /api/Movies/{id}` - Delete a movie

## Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## License

This project is licensed under the MIT License - see the LICENSE file for details.