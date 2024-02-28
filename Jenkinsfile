// pipeline {
//     agent any
//     stages {
//         stage('Build') {
//             steps {
//                 sh 'echo "Hello task1"'
//             }
//         }
//         stage('Test') {
//             steps {
//                 echo 'Run some unit tests'
//                 sh 'echo "Run an integration test"'
//             }
//         }
//         stage('Deploy') {
//             steps {
//                 sh 'echo "Deploy application"'
//             }
//         }
//     }
// }

pipeline {
    agent any
    
    environment{
        PATH_PROJECT = '/home/projects/cicd/'
    }
    stages {
        stage('Checkout') {
            steps {
                // Clean workspace before cloning
                deleteDir()

                // Clone the GitHub repository
                checkout scm
                // sh "sudo cp -r . $PATH_PROJECT"
                // echo "Checked out code to: $PATH_PROJECT"
            }
        }

        stage('Build and Run Docker Containers') {
            steps {
                // sh " cd $PATH_PROJECT \
                // && docker-compose up -d"
                // script {
                    
                //     // Assuming your .NET API solution is in the 'src' directory
                //     dir('/var/jenkins_home/workspace/CICDWithJenkinsfile') {
                //         // Build and run Docker containers using docker-compose.yml
                //         sh 'docker-compose -f -d'
                //     }
                // }

                sh 'docker-compose up -d'
            }
        }
    }

    post {
        success {
            echo 'Pipeline completed successfully!'
        }
        failure {
            echo 'Pipeline failed! Check logs for details.'
        }
    }
}
