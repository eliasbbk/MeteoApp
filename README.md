# Météo App - Console

## Contexte
Projet réalisé pour me familiariser avec API REST et la programmation asynchrone en C#.

## Fonctionnalités
- Demande le nom d'une ville à l'utilisateur
- Récupère la météo en temps réel via l'API wttr.in
- Affiche la température, l'humidité et les conditions météo

## Technologies
- C# (.NET)
- Appels API REST (HttpClient, async/await)
- Désérialisation JSON (System.Text.Json)
- Programmation orientée objet (classes imbriquées)

## Lancer le projet
```bash
dotnet run
```

## Pistes d'amélioration
- Gestion des erreurs (ville invalide, pas de connexion)
- Prévisions sur plusieurs jours
- Interface graphique (voir le projet MeteoAppGUI)