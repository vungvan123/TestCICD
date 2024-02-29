pipeline {
    agent any
    
    stages {
        stage('Checkout') {
            steps {
                // Clone the GitHub repository
                checkout scm
            }
        }

        stage('Cleanup') {
            steps {
                script {
                    //Stop and remove container
                    sh "docker-compose down"
                }
            }
        }

        stage('Build and Run') {
            steps {
                script {
                    // Run Docker Compose
                    sh "docker-compose up --build -d"
                }
            }
        }
    }
}
