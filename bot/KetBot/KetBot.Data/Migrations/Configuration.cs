namespace KetBot.Data.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<KetBot.Data.Models.KetBotContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(KetBot.Data.Models.KetBotContext context)
        {
            // -----------------------------------------------------------
            context.SelectiveForms.AddOrUpdate(p => p.Code,
                new SelectiveForm
                {
                    Code = "0",
                    Form = string.Join("\n", new string[] 
                    {
                        "포인트 통합",
                        "포인트 사용",
                        "광고 포인트 적립",
                        "멤버십",
                        "상점",
                        "버그신고",
                        "기타"
                    })
                },
                new SelectiveForm
                {
                    Code = "1",
                    Form = string.Join("\n", new string[]
                    {
                        "포인트 통합 오류",
                        "포인트 통합 취소",
                        "포인트 통합 기타",
                        "포인트 소멸"
                    })
                },
                new SelectiveForm
                {
                    Code = "2",
                    Form = string.Join("\n", new string[]
                    {
                        "포인트 사용"
                    })
                },
                new SelectiveForm
                {
                    Code = "3",
                    Form = string.Join("\n", new string[]
                    {
                        "바로적립",
                        "잠금화면 포인트"
                    })
                },
                new SelectiveForm
                {
                    Code = "4",
                    Form = string.Join("\n", new string[]
                    {
                        "등록 관련"
                    })
                },
                new SelectiveForm
                {
                    Code = "5",
                    Form = string.Join("\n", new string[]
                    {
                        "이용 관련",
                        "상품권"
                    })
                },
                new SelectiveForm
                {
                    Code = "6",
                    Form = string.Join("\n", new string[]
                    {
                        "화면 멈춤"
                    })
                },
                new SelectiveForm
                {
                    Code = "7",
                    Form = string.Join("\n", new string[]
                    {
                        "건의사항",
                        "계정 관련",
                        "클라이언트 관련",
                        "이용 관련",
                        "기타"
                    })
                },
                new SelectiveForm
                {
                    Code = "8",
                    Form = string.Join("\n", new string[]
                    {
                        "화면 멈춤"
                    })
                },
                new SelectiveForm
                {
                    Code = "11",
                    Form = string.Join("\n", new string[]
                    {
                        "전환버튼 클릭 후 반응이 없어요.",
                        "본인인증 과정에서 오류가 있어요.",
                        "보안문자 입력 과정에서 오류가 있어요.",
                        "포인트 통합을 했는데 그대로에요."
                    })
                },
                new SelectiveForm
                {
                    Code = "12",
                    Form = string.Join("\n", new string[]
                    {
                        "실수로 포인트 통합을 해버렸어요.",
                        "포인트 통합을 취소해주세요."
                    })
                },
                new SelectiveForm
                {
                    Code = "13",
                    Form = string.Join("\n", new string[]
                    {
                        "다른 카드사 포인트를 통합하고 싶어요.",
                        "통합한 포인트를 다른 카드사로 옮겨 주세요."
                    })
                },
                new SelectiveForm
                {
                    Code = "14",
                    Form = string.Join("\n", new string[]
                    {
                        "탈퇴했더니 포인트가 사라졌어요.",
                        "포인트가 사라졌어요."
                    })
                },
                new SelectiveForm
                {
                    Code = "21",
                    Form = string.Join("\n", new string[]
                    {
                        "포인트 사용법을 알고싶어요."
                    })
                },
                new SelectiveForm
                {
                    Code = "31",
                    Form = string.Join("\n", new string[]
                    {
                        "적립이 안됐어요."
                    })
                },
                new SelectiveForm
                {
                    Code = "32",
                    Form = string.Join("\n", new string[]
                    {
                        "적립 포인트 양이 너무 적어요."
                    })
                },
                new SelectiveForm
                {
                    Code = "41",
                    Form = string.Join("\n", new string[]
                    {
                        "멤버십 카드를 자동으로 등록하고 싶어요.",
                        "신용카드를 등록하고 싶어요.",
                        "바코드가 없는데 등록 방법을 알고 싶어요.",
                        "멤버십 포인트를 조회하고 싶어요."
                    })
                },
                new SelectiveForm
                {
                    Code = "51",
                    Form = string.Join("\n", new string[]
                    {
                        "상품 사용 방법을 알고싶어요.",
                        "사용 내역을 확인하고 싶어요.",
                        "다른 상품으로 교환하고 싶어요.",
                        "핀켓 상점 외의 곳에서 사용하고 싶어요.",
                        "해피머니 상품권 사용법을 알려주세요."
                    })
                },
                new SelectiveForm
                {
                    Code = "52",
                    Form = string.Join("\n", new string[]
                    {
                        "상품권 사용 방법을 알고싶어요.",
                        "상품권 수령은 어떻게 하나요?",
                        "상품권 기한이 지나버렸어요.",
                        "모바일 상품권 사용 잔액을 알려주세요."
                    })
                },
                new SelectiveForm
                {
                    Code = "61",
                    Form = string.Join("\n", new string[]
                    {
                        "화면이 멈췄어요.",
                        "잠금화면 해제 후 포인트가 들어오지 않아요."
                    })
                },
                new SelectiveForm
                {
                    Code = "71",
                    Form = string.Join("\n", new string[]
                    {
                        "건의사항이 있는데요."
                    })
                },
                new SelectiveForm
                {
                    Code = "72",
                    Form = string.Join("\n", new string[]
                    {
                        "탈퇴하는 방법을 알고싶어요.",
                        "번호/기기를 변경하고 핀켓을 쓰고싶어요."
                    })
                },
                new SelectiveForm
                {
                    Code = "73",
                    Form = string.Join("\n", new string[]
                    {
                        "재설치 시 기존 적립 포인트를 사용 할 수 있나요?"
                    })
                },
                new SelectiveForm
                {
                    Code = "74",
                    Form = string.Join("\n", new string[]
                    {
                        "로그인 하고싶어요.",
                        "로그아웃 하고싶어요.",
                        "아이디(비밀번호)를 알려주세요.",
                        "아이디 변경을 하고싶어요.",
                        "비밀번호를 변경하고싶어요.",
                        "이름을 바꾸고 싶어요.",
                        "잠금화면을 해제하고싶어요.",
                        "잠금화면 포인트 적립 주기를 알고싶어요.",
                        "사용법을 가르쳐주세요."
                    })
                },
                new SelectiveForm
                {
                    Code = "75",
                    Form = string.Join("\n", new string[]
                    {
                        "고객센터를 알려주세요."
                    })
                }
            );

            // -----------------------------------------------------------

            context.ExecutiveQuestions.AddOrUpdate(p => p.Code,
                new ExecutiveQuestion
                {
                    Code = "111",
                    Keyword = "포인트 전환",
                    Question = "전환버튼 클릭 후 반응이 없어요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            QuestionId = 1,
                            Text = "질문하신 내용은 최신 앱 버전에서 패치가 적용되었습니다. 다음 방법대로 시도해보세요. :]"
                        },
                        new Answer
                        {
                            Order = 20,
                            QuestionId = 1,
                            Text = "1. 기존에 설치된 앱 삭제\n 2. 구글 플레이 스토어에서 최신 버전으로 재설치"
                        },
                        new Answer
                        {
                            Order = 30,
                            QuestionId = 1,
                            Text = "이후에도 동일한 문제가 발생한다면, 매니저에게 물어봐주세요!!"
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "112",
                    Keyword = "본인인증",
                    Question = "본인인증 과정에서 오류가 있어요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            QuestionId = 1,
                            Text = "질문하신 내용은 최신 앱 버전에서 패치가 적용되었습니다. 다음 방법대로 시도해보세요. :]"
                        },
                        new Answer
                        {
                            Order = 20,
                            QuestionId = 1,
                            Text = "1. 기존에 설치된 앱 삭제 2. 구글 플레이 스토어에서 최신 버전으로 재설치"
                        },
                        new Answer
                        {
                            Order = 30,
                            QuestionId = 1,
                            Text = "이후에도 동일한 문제가 발생한다면, 매니저에게 물어봐주세요!!"
                        }
                    }
                }

            );

            //// -----------------------------------------------------------

            context.CommentDefinitions.AddOrUpdate(p => p.Code,
                new CommentDefinition
                {
                    Catetory = "Greetings",
                    Code = "RGB01",
                    Definition = "기본 인삿말",
                    Owner = "Bot",
                    Comments = new System.Collections.Generic.List<Comment>()
                    {
                        new Comment
                        {
                            Text = "안녕하세요! :]"
                        },
                        new Comment
                        {
                            Text = "오! 부르셨나요, 회원님?"
                        },
                        new Comment
                        {
                            Text = "저를 찾으셨다고 들었어요."
                        }
                    }
                }
                //,
                //new CommentDefinition
                //{
                //    Catetory = "",
                //    Code = "",
                //    Definition = "",
                //    Owner = "",
                //    Comments = new System.Collections.Generic.List<Comment>()
                //    {
                //        new Comment
                //        {
                //            Text = ""
                //        },
                //        new Comment
                //        {
                //            Text = ""
                //        },
                //        new Comment
                //        {
                //            Text = ""
                //        }
                //    }
                //}
            );

            //// -----------------------------------------------------------
        }
    }
}
