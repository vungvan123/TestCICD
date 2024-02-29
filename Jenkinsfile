pipeline {
    agent any
    
    environment {
        NAME_BACKEND = 'hihi.productapi'
    }

    stages {
        stage('Checkout') {
            steps {
                // Clean workspace before cloning
                deleteDir()

                // Clone the GitHub repository
                checkout scm
            }
        }

        stage('Cleanup') {
            steps {
                script {
                    //Stop and remove container + image old
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
