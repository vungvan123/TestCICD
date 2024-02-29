pipeline {
    agent any
    
    environment {
        CONTAINER_NAME = 'hihi.productapi'
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

        // stage('Setup Environment') {
        //     steps {
        //         script {
        //             // Install Docker Compose
        //             // sh "usermod -aG docker vungtv"
        //             // sh "curl -L https://github.com/docker/compose/releases/download/\${DOCKER_COMPOSE_VERSION}/docker-compose-\$(uname -s)-\$(uname -m) -o ${DOCKER_COMPOSE_PATH}"
        //             // sh "chmod +x ${DOCKER_COMPOSE_PATH}"

        //             // Print Docker Compose version
        //             sh 'docker --version'
        //             sh 'docker-compose --version'
        //             sh 'docker-compose --version'
        //         }
        //     }
        // }

        stage('Stop and remove container + image old') {
            steps {
                script {
                    sh "docker strop ${CONTAINER_NAME}"
                    sh "docker container rm ${CONTAINER_NAME}"
                    sh "docker image rm ${CONTAINER_NAME}"
                }
            }
        }

        stage('Build and Run') {
            steps {
                script {
                    // Run Docker Compose
                    sh "docker-compose up -d"
                }
            }
        }

        // stage('Cleanup') {
        //     steps {
        //         script {
        //             // Stop and remove Docker Compose services
        //             sh "docker-compose down"
        //         }
        //     }
        // }
    }
}
